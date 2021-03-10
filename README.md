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

Inversely, if the host wants to retrieve data from the storage device, the AES engine decrypts the cipher text in the NAND flash, and then transmits data to the host as plain text. The encryption/decryption process is done at the flash level and does not require host intervention, so there is no performance degradation and data transfer does not slow down.


 
