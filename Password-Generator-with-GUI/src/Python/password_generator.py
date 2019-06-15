"""
MIT License

Copyright (c) 2019 AlexTemnyakov

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
v0.6
"""

import random
import sys
import json


def generate_password(length):
    password = ""
    for i in range(length):
        # from 33 because all symbols before from 0 to 32 are not visible, 127 is not visible
        password += chr(random.randint(33, 127))
    return password
    
def save_passwords(listOfPasswords):
    with open("out\\passwords.txt", "w", encoding="utf-8") as file:
        i = 1
        for password in listOfPasswords:
            file.write(str(i) + ". Password: " + password + "\n")
            i += 1


if __name__ == "__main__":
    filename = sys.argv[ 1 ]
    with open(filename) as data_file:
        input_args = json.loads(data_file.read())
    length = int(input_args.get('length'))
    count = int(input_args.get('count'))
    listOfPasswords = []
    for i in range(count):
        listOfPasswords.append(generate_password(length))
    save_passwords(listOfPasswords)


