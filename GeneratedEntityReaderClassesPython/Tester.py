import json
from FastLZ import FastLZ
from NoitaStream import NoitaStream
from NoitaStreamDebug import NoitaStreamDebug
from EntityFile import EntityFile
import cProfile
import sys, glob
import time

def doallfiles():
    files = glob.glob("C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\entities_*.bin")
    for file in files:
        f = open(file, "rb")
        lz = FastLZ()
        decoded = lz.Decode(f.read())
        noitastream = NoitaStream(decoded)
        ef = EntityFile()
        ef.Read(noitastream)

        noitastreamto = NoitaStream(b"")
        ef.Write(noitastreamto)

        noitastreamto.content.seek(0)
        thevalue = noitastreamto.content.read()

        #if decoded == thevalue:
        #    print("YAY!")
        #else:
        #    print("AWWW")

        print("File1: " + str(len(decoded)) + " File2: " + str(len(thevalue)))

#f1 = open("test1.json", "w")

#def custom_json(obj):
#    if isinstance(obj, bytes):
#        return "HEX SHIT HERE WOO"
#    return obj.__dict__

#f1.write(json.dumps(ef, default=custom_json, indent="  "))
#print(repr(ef))
start = time.time()
doallfiles()
#cProfile.run("doallfiles()")
end = time.time()

print(f"Total runtime of the program is {end - start} seconds")