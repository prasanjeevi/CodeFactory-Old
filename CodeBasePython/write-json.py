import json
with open('data.json', 'r') as input:
	obj = json.load(input)
	print('Hello ' + obj['name'])
	with open('output.txt', 'w') as output:
		output.write('Hello ' + obj['name'] + '\n' + 'Hobbies are ')
		for hobby in obj['hobbies']:
			print(hobby)
			output.write(hobby + '\n')
