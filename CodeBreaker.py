"""
Encoding and Decoding Gui For Multipurpouse Use, Made By Rehan. No copyright laws.

"""

#Necessary imports
from os.path import exists, join
from os import urandom, getcwd, system
from time import sleep
from cryptography.fernet import Fernet
from Crypto.Cipher import AES
from Crypto import Random
from base64 import urlsafe_b64encode, urlsafe_b64decode, b64encode, b64decode
import hashlib
from sys import exit, argv

#Necessary variables
dalpha = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
enalpha = ['1', 'c', 'd', 'e', '2', 'g', 'h', 'i', '3', 'k', 'l', 'm', 'n', 'o', '4', 'q', 'r', 's', 't', 'u', '5', 'w', 'x', 'y', 'z', '6']
specialLets = ['!', '?', ']', '[', '|', '-', '=', '*', '%', '$', '#', '@', '.', ',']

# Custom AES implementation
class AESCipher(object):


    def __init__(self, key):
        self.bs = AES.block_size
        self.key = hashlib.sha256(key).digest()

    def encrypt(self, raw):
        raw = self._pad(raw.decode())
        iv = Random.new().read(AES.block_size)
        cipher = AES.new(self.key, AES.MODE_CBC, iv)
        return b64encode(iv + cipher.encrypt(raw.encode()))

    def decrypt(self, enc):
        enc = b64decode(enc)
        iv = enc[:AES.block_size]
        cipher = AES.new(self.key, AES.MODE_CBC, iv)
        return self._unpad(cipher.decrypt(enc[AES.block_size:]))

    def _pad(self, s):
        return s + (self.bs - len(s) % self.bs) * chr(self.bs - len(s) % self.bs)

    @staticmethod
    def _unpad(s):
        return s[:-ord(s[len(s)-1:])]

# Key Logic
if not exists(join(getcwd(), 'key.txt')):
    with open("key.txt", 'wb') as f:
        f.write(Fernet.generate_key())
        f.close()
else:
    pass
if not exists(join(getcwd(), 'aes_key.txt')):
    with open("aes_key.txt", 'wb') as f:
        random = urandom(16)
        print(random)
        f.write(random)
        f.close()
else:
    pass

# Reading Keys
with open("key.txt", 'rb') as f:
    t = Fernet(f.read())
    f.close()
with open("aes_key.txt", 'rb') as f:
    cipher = AESCipher(f.read())
    f.close()

# Fernet Encrypt Function
def encrypt(message: bytes) -> bytes:
    f = open("key.txt", 'rb')
    return Fernet(f.read()).encrypt(message)

# Fernet Decrypt Function
def decrypt(message: bytes) -> bytes:
    f = open("key.txt", 'rb')
    return Fernet(f.read()).decrypt(message)

# File enccrypting function.
def encodeFile(filename):
    # Read file, and if file not found, trigger error.
    try:
        with open(filename, 'rb') as f:
            read = f.read()
    except FileNotFoundError as e:
        print("File not found!")
        raise FileNotFoundError(" ")
    # Using other functions to encrypt
    encodedOutput = encrypt(read)
    encodedOutput = urlsafe_b64encode(encodedOutput)
    encodedOutput = cipher.encrypt(encodedOutput)
    # Save the new encoded output to the file, and return
    with open(filename, 'wb') as f:
        f.write(encodedOutput)
    return

# File decrypting function
def decodeFile(filename):
    try:
        with open(filename, 'rb') as f:
            read = f.read()
    except FileNotFoundError as e:
        print("File not found")
        raise FileNotFoundError(" ")

    decodedOutput = cipher.decrypt(read)
    decodedOutput = urlsafe_b64decode(decodedOutput)
    decodedOutput = decrypt(decodedOutput)
    with open(filename, 'wb') as f:
        f.write(decodedOutput)
        f.close()
    print("File overwritten with new decoded output")
    return decodedOutput
#Encode Function
def encode(msg):
    wordlist = []
    otherwordlist = []
    found = None
    msg = msg.lower()
    theELetters = []
    for letter in msg:
        count = 0
        if letter == ' ':
            theELetters.append(letter)
            continue
        elif letter in specialLets:
            theELetters.append(letter)
            continue
        else:
            if (letter == "("):
                found = True
            if (letter == ")"):
                wordlist.append(letter)
                found = False
                theELetters.append("".join(wordlist))
                wordlist.clear()
            if (found):
                wordlist.append(letter)
        for a in dalpha:
            if letter == a:
                eletter = enalpha[count]
                theELetters.append(eletter)
            elif not letter == a:
                count +=1
    encodedOutput = ''.join(theELetters)
    encodedOutput = encodedOutput.encode()
    encodedOutput = encrypt(encodedOutput)
    encodedOutput = urlsafe_b64encode(encodedOutput)
    encodedOutput = cipher.encrypt(encodedOutput)
    return encodedOutput

#Decode Function
def decode(msg):
    wordlist = []
    otherwordlist = []
    found = None
    try:
        msg = msg.encode()
    except AttributeError as e:
        pass
    msg = decrypt(urlsafe_b64decode(cipher.decrypt(msg))).decode()
    msg = msg.lower()
    theDLetters = []
    for letter in msg:
        count = 0
        if letter == ' ':
            theDLetters.append(letter)
            continue
        elif letter in specialLets:
            theDLetters.append(letter)
            continue
        else:
            if (letter == "("):
                found = True
                continue
            if (letter == ")"):
                found = False
                theDLetters.append("".join(wordlist))
                wordlist.clear()
            if (found):
                wordlist.append(letter)
        for a in enalpha:
            if found:
                count += 1
                continue
            if letter == a:
                dletter = dalpha[count]
                theDLetters.append(dletter)
            elif not letter == a:
                count += 1
    decodedOutput = ''.join(theDLetters)
    return decodedOutput

# Main loop
while True:
    print("Would you like to encode, or decode? Type * to exit. E / D")
    answer = input("> ")
    if (answer == "E") or (answer == "e"):
        print("Would you like to change the current keys? Y / N")
        a = input("> ")
        if (a == "y") or (a == "Y"):
            with open("key.txt", "wb") as f:
                print("Name of file saved with fernet key: ")
                an = input("> ")
                print("Changing Fernet Key...")
                f2 = open(an)
                f.write(f2.read())
                sleep(1.5)
                print("Changed!")
            with open ("aes_key.txt", "wb") as f:
                print("Name of file saved with aes key: ")
                an = input ("> ")
                print("Changing...")
                f.write(an.encode())
                del cipher
                cipher = AESCipher(an)
                sleep(1.5)
                print("Changed!")
        if (a == "n") or (a == "N"):
            print("Okay!")
        print("Would you like to encode from command prompt, or encode a file? C / F")
        a = input("> ")
        if (a == "F") or (a == "f"):
            print("Filename?")
            try:
                encodeFile(input("> "))
            except FileNotFoundError as e:
                print("The passed in filename was not found!")
                continue
            print("File encrypted")
        if (a == "C") or (a == "c"):
            encodeTest = encode(input("Encode:"))
            print(encodeTest)
        with open("key.txt", "rb") as f:
            with open("saved_key.txt", "wb") as f2:
                f2.write(f.read())
                print("Fernet Key is saved as saved_key.txt")
            f.close()
        with open("aes_key.txt", "rb") as f:
            with open("saved_aes_key.txt", "wb") as f2:
                f2.write(f.read())
                print("Fernet Key is saved as saved_aes_key.txt")
            f.close()
        if (a == "C") or (a == "c"):
            print("Would you like to save to a file? Y / N")
            a = input("> ")
            if (a == "y") or (a == "Y"):
                print("Name the file...")
                b = str(input("> "))
                with open(b, 'wb') as f:
                    print("Saving...")
                    f.write(encodeTest)
                    sleep(1.5)
                    print("Saved!")
            elif (a == "n") or (a == "N"):
                print("Okay then!")
                system("pause")
        system("pause")
    elif (answer == "D") or (answer == "d"):
        print("Would you like to change the current keys? Y / N")
        a = input("> ")
        if (a == "y") or (a == "Y"):
            with open("key.txt", "wb") as f:
                print("Name of file saved with fernet key: ")
                an = input("> ")
                print("Changing Fernet Key...")
                f2 = open(an, 'rb')
                f.write(f2.read())
                sleep(1.5)
                f.close()
                print("Changed!")
            with open ("aes_key.txt", "wb") as f:
                print("Name of file saved with aes key: ")
                an = input ("> ")
                print("Changing...")
                f2 = open(an, 'rb')
                f.write(f2.read())
                sleep(1.5)
                f.close()
                with open("aes_key.txt", "rb") as f:
                    del cipher
                    cipher = AESCipher(f.read())
                    f.close()
                print("Changed!")
        if (a == "n") or (a == "N"):
            print("Okay!")
        print("Would you like to decode from command prompt, or decode a file? C / F")
        answer = input("> ")
        if (answer == "C") or (answer == "c"):
            decodeTest = decode(input("Decode:"))
        elif (answer == "F") or (answer == "f"):
            print("What is the name of the file you'd like to open?")
            name = input("> ")
            decodeTest = decodeFile(name)
            print("Decoding...")
            sleep(1.5)
            print("Decoded!")
        if (".txt" in name):
            print(decodeTest.decode())
        print("Would you like to save to a file? Y / N")
        a = input("> ")
        if (a == "y") or (a == "Y"):
            print("Name the file...")
            b = str(input("> "))
            with open(b, 'w') as f:
                print("Saving...")
                f.write(decodeTest)
                sleep(1.5)
                print("Saved!")
        elif (a == "n") or (a == "N"):
            print("Okay then!")
        system("pause")
    elif (answer == "*"):
        exit()
