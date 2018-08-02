import json
with open('data.json', 'r') as input:
	obj = json.load(input)
	print('Hello ' + obj['name']) 
