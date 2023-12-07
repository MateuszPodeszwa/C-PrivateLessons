# Challenge: The Magic Cannon

Skorin, a member of Consola'''s wall guard, has constructed a magic cannon that
draws power from two gems: a fire gem, and an eletric gem. Every third turn of a 
crank, the fire gem actiavtes, and the cannon produces a fire blast. 

The electric gem activates every fifth turn of the crank, and the cannon makes an 
elecric blast. When the two line up, it generates a potent combined blas. Skorin 
would like your help to produce a program that can warn the crew about which turns 
of the crank will produce the different blasts before they do it.

A partial output of the desired program looks like this:

```markdown
1: Normal
2: Normal
3: Fire
4: Normal
5: Electric
6: Fire
7: Normal
```

## Objectives

1. Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect. (the % operator may be used).
2. Change the colour of the output based on the type of blast. (For example, red for fire, yellow for electric, blue for electric and fire).
