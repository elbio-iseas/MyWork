import re

def count_code(str):
        
   codelist = re.findall('[c][o][a-z][e]',str)
   
   return len(codelist)
    
print(count_code('aaacodebbb'))
print(count_code('codexxcode'))
print(count_code('cozexxcope'))
print(count_code(''))


