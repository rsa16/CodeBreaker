# CodeBreaker
 An GUI encryption tool that encrypts, text, files, and passwords.
## What It Does
 CodeBreaker is an encryption and decryption tool, specifically targeted to encrypt and send secret messages. It allows different encryption algorithms, many of which I've invented myself. It can also serve as a text editor, but not with many features. Encrypting is as simple as a few clicks, as such is decrypting. For more advanced users you can do the Manual Encryption. 
## How it works
CodeBreaker uses a Python CLI Script, also made by me and calls arguments from it. I wanted to divide the cryptography side to Python and the GUI side to C sharp, which is why CodeBreaker is written using both languages. Python is essentially my backend, where C Sharp is the front end in the program. In the CodeBreakerScript repository I explain more into how the script itself works.

## Supported Encryption Algortithms
As of now, it supports 6 encryption algorithms, listed below:
- Fernet Encryption
- AES Encryption
- Base64 Encoding
- Sim Algorithm
- Pidge Cipher
- SubCaes Algorithm
More into detail on them below.
### Fernet Encryption
A symmetrical encryption, built on top of some other primitive encryptions.
Fernet uses AES in CBC mode with a 128-bit key for encryption; using PKCS7 padding.
It also uses HMAC with SHA256 for authenthication.
All innitilization vectors are generated with python os.urandom()

### AES Encryption
According to article: https://www.atpinc.com/blog/what-is-aes-256-encryption
> They make use of a hardware-based set of security modules and an AES engine. When the host writes data to the flash storage device, a Random Number Generator (RNG) generates the 256-bit symmetric cipher key, which is passed to the AES engine. The AES engine encrypts the plain text (source data) into cipher text (encrypted data) and sends it to the NAND flash for storage.
> Inversely, if the host wants to retrieve data from the storage device, the AES engine decrypts the cipher text in the NAND flash, and then transmits data to the host as plain text. The encryption/decryption process is done at the flash level and does not require host intervention, so there is no performance degradation and data transfer does not slow down.
> 
### Base64 Encoding
According to quora page: https://www.quora.com/What-is-base64-encoding
> String to be encoded : “ace”, Length=3
> 1) Convert each character to decimal.
> a= 97, c= 99, e= 101
> 2) Change each decimal to 8-bit binary representation.
> 97= 01100001, 99= 01100011, 101= 01100101
> Combined : 01100001 01100011 01100101
> 3) Seperate in a group of 6-bit.
> 011000 010110 001101 100101
> 4) Calculate binary to decimal
> 011000= 24, 010110= 22, 001101= 13, 100101= 37
> 5) Covert decimal characters to base64 using base64 chart.
> 24= Y, 22= W, 13= N, 37= l
> “ace” => “YWNl”

### Sim Algorithm
I invented this one myself. To be perfectly honest this is actually quite simple. I combine multiple algorithms into one. First I run a SubCaes algorithm, then a fernet encryption, then an aes encryption, and then a base64 encryption. Quite crude, but still an algorithm.

### SubCaes Algorithm
Now this one is built on top of a Caesar Shift. Particularly this encryption isn't very safe, as it a subsitution cipher with no real key. All vowels are replaced with numbers, and all other letters are shifted 1. Perhaps you can change how much they are shifted, and it can be a better algorithm?

### Pidge Cipher
Particularly named the Pidge Cipher because I was inspired by a man in a show named Voltron to invent this encryption.
This ones quite complicated, so I put this into the script. First lets say we want to encrypt hi.
First I need to define a keyword. For this, lets make it hey.

hey is longer then hi, so i need to take the remove the last letter

This now becomes he.
hi
he

The vigenere table is basically a multiplication table.
On it I look up h and h, and i get o.
Then I look up i and e, and I get m.
so hi turns into om.

Now I do a caesar shift of 1, so om turns into pn.
P is the 16th letter in the alphabet, and N is the 14th letter.
So PN becomes 16, 14
Then I run a series of calculations. For example, I can multiply each number by 2 and add 5.
16 * 2 = 32 + 5 = 37
14 * 2 = 28 + 5 = 33
So 16, 14 turns into 37, 33

Replacing the comma with a dot, I get 37.33

From here I can base64 encode it, put it in morse code, or even save it to frequencies in a file. That's the Pidge Cipher.




 
