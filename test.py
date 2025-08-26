import json



with open("./api.json") as json_data:
    data = json.load(json_data)

catergories = list(data.keys())

name_converter = {"point_2d": "Point2D", "vector_2d": "Vector2D", "circle": "Circle", "quad": "Quad", "color": "Color", "drawing_options": "DrawingOptions"}

#print(data["types"]["structs"][0].keys())


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
        for name in name_converter.keys():
            if self.convert_type(name) in output:
                output = output.replace(self.convert_type(name), "")
        
        return output

    # Input example data[types][structs]
    def get_struct_name(self, line, struct_index):
        struct_name = self.convert_type(line[struct_index]["name"])
        print("Struct name: " + struct_name)
        signature = "public struct " + struct_name + " {\n\n"
        properties = ""
        for attribute in line[struct_index]["fields"].keys():
            properties += "public "
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
                    method_name = method_name[:-1]
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
                    methods += method_name + "\n}\n"
            method_index += 1
        return methods



struct_data = StructOSaurusRex()


index = 0
output = ""
while index < len(data["types"]["structs"]):
    print("========================")
    struct_name, signature, properties = struct_data.get_struct_name(data["types"]["structs"], index)
    methods = struct_data.get_struct_methods(data["types"]["structs"], struct_name, index)
    print("========================")
    output += "\n"
    output += signature + "\n"
    output += properties + "\n"
    output += methods + "}\n"
    index += 1


o = open("structs.cs", "w")

o.write(output)

#print(data["types"]["structs"][0]["methods"][0])