# CodeBreaker
 An encryption tool that encrypts, text, files, and passwords.
### What It Does
 It encrypts, with a custom subsitution cipher, a fernet encryption (saves key as by defualt saved_key.txt), a base64 encryption, and an AES encryption (saves aes_key by defualt as saved_aes_key.txt)
 It also supports argument handling, so the tool may be used in other programs.
### How it works
In the encode function, it goes through each letter in a string. Then it subsitutes that letter, with another letter specified in a list. Then it does further encryption. First it encrypts it with the fernet symmetrical algorithm. Then it base64encodes it. After that it AES encrypts it. And lastly it returns the result. Then it output's the result, and you have an option of saving the result to a file. The same thing happens in encodefile, except it only uses subsitution cipher when encrypting txt files (assuming it has no words that cannot be typed by a keyboard). It also rewrites the file with the new encrypted data.
The decode function is the same thing, but reversed. The decodefile is reverse as well.
 
