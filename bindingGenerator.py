import json


js_import_binding = "SplashKitBackendWASM."


name_converter = {"point_2d": "Point2D", "vector_2d": "Vector2D", "circle": "Circle", "quad": "Quad", "color": "Color", "drawing_options": "DrawingOptions", "line": "Line", "rectangle": "Rectangle", "triangle": 'Triangle'}



class StructOSaurusRex():
    def convert_type(self, type):
        global name_converter
        swappable_names = name_converter.keys()
        if type in swappable_names:
            return name_converter[type]
        else:
            return type

    def strip_types(self, method_text):
        global name_converter
        output = method_text
        standard_type = ["int", "double", "string"]
        for name in name_converter.keys():
            if self.convert_type(name) in output:
                output = output.replace(self.convert_type(name), "")

        for type in standard_type:
            if type in output:
                output = output.replace(type, "")
        
        return output

    # Input example data[types][structs]
    def get_struct_name(self, line, struct_index):
        struct_name = self.convert_type(line[struct_index]["name"])
        print("Struct name: " + struct_name)
        signature = "public struct " + struct_name + " {\n\n"
        properties = ""
        for attribute in line[struct_index]["fields"].keys():
            properties += "       public "
            print("==== name: " + attribute + " ======")
            if line[struct_index]["fields"][attribute]["is_const"] == "true":
                properties += "const "

            properties += self.convert_type(line[struct_index]["fields"][attribute]["type"])

            if line[struct_index]["fields"][attribute]["is_array"]:
                properties += "[] "
            else:
                properties += " "
            properties += attribute.capitalize() + ";\n"
        
        return struct_name, signature, properties

    # Input example data[types][structs]
    def get_struct_methods(self, line, struct_name, struct_index):
        # Code to get methods
        method_signature = ""
        method_name = ""
        method_index = 0
        methods = ""
        while method_index < len(line[struct_index]["methods"]):
            for method in line[struct_index]["methods"][method_index]["signatures"]["csharp"]:
                # Apply simple change if thing is struct.method
                if struct_name + "." in method:
                    method_signature = method.replace(struct_name + ".", "")
                    method_signature = method_signature[:-1]
                    method_signature = "      " + method_signature
                    methods += method_signature + "{\n"
                # Find method struct.method calls
                else: 
                    # Get the class the method is from
                    classes_string = method.split(".")
                    index = len(classes_string[0]) -1
                    class_name = ""
                    while index > 0:
                        if classes_string[0][index] == " ":
                            break
                        class_name += classes_string[0][index]
                        index -= 1
                    class_name = class_name[::-1]
                    # Resassemble the method name
                    method_name = class_name + "." + classes_string[1]
                    # Remove the semi colon from the end
                    # Determine if a struct val needs to be replaced by struct this
                    run_check = True
                    target = 0
                    if " " + struct_name + " " in method_name:
                        target = method_name.index(" " + struct_name + " ")
                    elif "(" + struct_name + " " in method:
                        target = method_name.index("(" + struct_name + " ")
                    else:
                        run_check = False
                    
                    #Replace struct val with struct this
                    removal_string = ""
                    while target < len(method_name) and run_check:
                        if method_name[target] == ")" or method_name[target] == ",":
                            break
                        removal_string += method_name[target]
                        target += 1
                    if run_check:
                        method_name = method_name.replace(removal_string, " " + struct_name + " this")
                    method_name = self.strip_types(method_name)
                    methods += "            " + method_name + "\n}\n"
                    
            method_index += 1
        return methods



struct_data = StructOSaurusRex()


def get_bindings(line):
    global maps
    cpp_name = line["name"]

    for definition in line["signatures"]["csharp"]:

        signature = {
            "function_definition": "",
            "function_to_bind": cpp_name
            }
        
        function_definition = ""

        if "static" in definition:
            location = definition.index("static") + len("static")
            part_two = definition[location:]
            part_one = definition[:location]
            function_definition = part_one + " partial" + part_two
        else:
            location = definition.index("public") + len("static")
            part_two = definition[location:]
            part_one = definition[:location]
            function_definition =  part_one + " partial" + part_two

        if " { get }" in definition:
            function_definition = function_definition.replace(" { get }", ";")

        if " { set }" in definition:
            function_definition = function_definition.replace(" { set }", ";")

        if "." in definition:
            classes_string = definition.split(".")[0]
            index = len(classes_string) -1
            class_name = ""
            while index > 0:
                if classes_string[index] == " ":
                    break
                class_name += classes_string[index]
                index -= 1
            class_name = class_name[::-1]


            if class_name not in maps.keys():
                maps[class_name] = []
        else:
            continue
        function_definition = function_definition.replace(class_name + ".", "")

        signature["function_definition"] = function_definition

        maps[class_name].append(signature)
    



#! Program entry point

with open("./api.json") as json_data:
    data = json.load(json_data)

catergories = list(data.keys())
catergory = 0


maps = {}
structs = ""

while catergory < len(catergories):
    function_index = 0
    while function_index < len(data[catergories[catergory]]["functions"]):
        get_bindings(data[catergories[catergory]]["functions"][function_index])
        function_index += 1
    struct_index = 0
    while struct_index < len(data[catergories[catergory]]["structs"]):
        print("========================")
        struct_name, signature, properties = struct_data.get_struct_name(data[catergories[catergory]]["structs"], struct_index)
        methods = struct_data.get_struct_methods(data[catergories[catergory]]["structs"], struct_name, struct_index)
        print("========================")
        structs += "\n"
        structs += signature + "\n"
        structs += properties + "\n"
        structs += methods + "}\n"
        struct_index += 1

    catergory += 1


# Output the file
output_file = open("SplashKitBindings.Generated.cs", "w")

classes = maps.keys()
output = "using System.Runtime.InteropServices.JavaScript; \n\nnamespace SplashKitSDK \n{\n"
for SK_class in classes:
    output += "   public partial class " + SK_class + "\n   {\n"

    for definition in maps[SK_class]:
        output += "      [JSImport(\"SplashKitBackendWASM." + definition["function_to_bind"] +"\", \"main.js\")] \n"
        output += "      " + definition["function_definition"] + "\n\n"

    output += "     } \n\n"

output += structs
output += "} \n"


output_file.write(output)