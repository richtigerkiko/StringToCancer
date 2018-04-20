def create(notCancerYet):
    i = 0
    cancerString = ""
    for c in notCancerYet :
        if c == " " :
            i+=1
        if i % 2 == 0 :
            cancerString = cancerString + c.upper()
        else:
            cancerString = cancerString + c.lower()
        i+=1
    return cancerString;
