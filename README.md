# CodeBreaker
 An GUI encryption tool that encrypts, text, files, and passwords.
### What It Does
 CodeBreaker is an encryption and decryption tool, specifically targeted to encrypt and send secret messages. It allows different encryption algorithms, many of which I've invented myself. It can also serve as a text editor, but not with many features. Encrypting is as simple as a few clicks, as such is decrypting. For more advanced users you can do the Manual Encryption. 
### How it works
CodeBreaker uses a Python CLI Script, also made by me and calls arguments from it. I wanted to divide the cryptography side to Python and the GUI side to C sharp, which is why CodeBreaker is written using both languages. Python is essentially my backend, where C Sharp is the front end in the program. In the CodeBreakerScript repository I explain more into how the script itself works.

### Supported Encryption Algortithms
As of now, it supports fernet, base64, and aes. It also supports three encryption algorithms invented by yours truly. The first algorithm: The Sim Algorithm, Second: The SubCaes Algorithm, Third: The Pidge Algorithm.
 
