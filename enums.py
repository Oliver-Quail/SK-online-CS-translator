import json


with open("./api.json") as json_data:
    data = json.load(json_data)



print(data["sprites"]["enums"][0]["name"])
print(data["sprites"]["enums"][1]["signatures"]["csharp"])