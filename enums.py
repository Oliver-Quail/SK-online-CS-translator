import json


with open("./api.json") as json_data:
    data = json.load(json_data)

def get_enum(line, enum_index):
    print(line["enums"][enum_index]["name"])
    print(line["enums"][enum_index]["signatures"]["csharp"])
    enum_values = line["enums"][enum_index]["signatures"]["csharp"].split(",")

    print(enum_values)

    first = enum_values[0]
    first = first[first.index("{") + 1:]

    last = enum_values[len(enum_values) -1]
    last = last[:-1]
    enum_values[0] = " " + first
    enum_values[len(enum_values) -1] = last
    enum_name = first.split(".")[0]
    enum = "enum " + enum_name + "{ \n"

    for value in enum_values:
        enum += value.split(".")[1] + ",\n"

    enum += "}\n"

    return enum


index = 0
enums = ""

print(len(data["resources"]["enums"]))

while index < len(data["resources"]["enums"]):
    enums += get_enum(data["resources"], index)
    index += 1

print(enums)