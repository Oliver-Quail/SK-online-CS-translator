import json

maps = {}

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
    

def get_structs(line): 
    pass


js_import_binding = "SplashKitBackendWASM."


with open("./api.json") as json_data:
    data = json.load(json_data)

catergories = list(data.keys())
catergory = 0


while catergory < len(catergories):
    if catergories[catergory] == "types":
        catergory += 1
        continue
    function_index = 0
    while function_index < len(data[catergories[catergory]]["functions"]):
        get_bindings(data[catergories[catergory]]["functions"][function_index])
        function_index += 1
    catergory += 1

output_file = open("SplashKitBindings.Generated.cs", "w")

classes = maps.keys()

output = "using System.Runtime.InteropServices.JavaScript; \n\nnamespace SplashKitSDK \n{\n"

print(classes)

for SK_class in classes:
    output += "   public partial class " + SK_class + "\n   {\n"

    for definition in maps[SK_class]:
        output += "      [JSImport(\"SplashKitBackendWASM." + definition["function_to_bind"] +"\", \"main.js\")] \n"
        output += "      " + definition["function_definition"] + "\n\n"
        print(definition)

    output += "     } \n\n"

output += "} \n"

output_file.write(output)