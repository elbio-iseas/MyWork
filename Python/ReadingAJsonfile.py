import json
f = open('vehicles.json')
vehicles = json.load(f)
for i in vehicles['myVehicles']:
    print('year : ', i['year'])
    print('make : ', i['make'])
    print('model: ', i['model'])
    print('color: ', i['color'])
    print('transmission: ', i['transmission'])
    print()
f.close()
