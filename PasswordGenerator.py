import random
p=""
lp="qwertyuiop[]';lkjhgfdsazxcbnm,./=-0987654321+_)(*&^%$#@!}{POIUYTREWQ|\":LKJHGFDSA?><MNBVCXZ"
maxchr=8
for i in range(0,maxchr):
  p += lp[random.randint(0,len(lp))]
print("Your password is: \n"+p)
