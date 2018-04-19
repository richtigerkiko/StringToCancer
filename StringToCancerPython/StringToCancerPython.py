def StringToCancer( notCancerYet ):

    i = 0
    cancerString = ""

    for char in notCancerYet :
        if char == " " :
            i+=1
        if i % 2 == 0 :
            cancerString = cancerString + char.upper()
        else:
            cancerString = cancerString + char.lower()
        i+=1

    return cancerString;

print(StringToCancer (input("Insert uncancerous string: ")))

