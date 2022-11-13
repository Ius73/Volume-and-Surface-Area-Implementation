def Cube_Volume_Area(x,y,z):
    result1 = x * y * z
    result2 = ((x * y) * 2) + ((x * z) * 2) + ((z * y) * 2)
    txt1 = "the volume of the cube is {}m"
    print(txt1.format(int(result1)))
    txt2 = "the area of the cube is {}m"
    print(txt2.format(int(result2)))

def Sphere_Volume_Area(r):
    result1 = (4/3)*3.14159265359*(r**3)
    result2 = 4*3.14159265359*(r**2)
    txt1 = "the volume of the sphere is {}m"
    print(txt1.format(int(result1)))
    txt2 = "the area of the sphere is {}m"
    print(txt2.format(int(result2)))

def check_loop_no():
    con = str(input("do you want to continue? Y/N: "))
    con = con.upper()
    return con

n = 0
while 1 < 2:
    letters = ['C','S','E']
    print(" C for Cube")
    print(" S for Sphere")
    print(" E for exit")
    user_shape = str(input("insert a letter: "))
    user_shape = user_shape.upper()
    if user_shape == letters[0]:
        x = int(input("insert the Width: "))
        y = int(input("insert the Length: "))
        z = int(input("insert the Height: "))
        Cube_Volume_Area(x,y,z)
        n = n + 1
    if user_shape == letters[1]:
        r = int(input("insert the radius: "))
        Sphere_Volume_Area(r)
        n = n + 1
    if user_shape == letters[2]:
        break
    if n == 3:
        c = check_loop_no()
        if c == "Y":
            n = 0
            continue
        if c == "N":
            break
        else:
            check_loop_no()
