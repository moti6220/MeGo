import random


print("""Welcome to the game Hangman
    _    _
   | |  | |
   | |__| | __ _ _ __   __ _ _ __ ___   __ _ _ __
   |  __  |/ _' | '_ \ / _' | '_ ' _ \ / _' | '_ \\
   | |  | | (_| | | | | (_| | | | | | | (_| | | | |
   |_|  |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                        __/ |
                       |___/""")

max_tries = random.randint(5,10)
print(max_tries)
picture_7 = '''
    x-------x
    |       |
    |       0
    |      /|\\
    |      / \\
    |
    '''
print(picture_7)
picture_6 = '''
    x-------x
    |       |
    |       0
    |      /|\\
    |      /
    |
  '''
print(picture_6)
picture_5 = '''
    x-------x
    |       |
    |       0
    |      /|\\
    |
    |
    '''
print(picture_5) 
picture_4 = '''
    x-------x
    |       |
    |       0
    |       |
    |
    |
    '''
print(picture_4)
picture_3 = '''
    x-------x
    |       |
    |       0
    |
    |
    |
    '''
print(picture_3)
picture_2 = '''
    x-------x
    |
    |
    |
    |
    |
    '''
print(picture_2)
picture_1 = '''
 x-------x
 '''
print(picture_1)