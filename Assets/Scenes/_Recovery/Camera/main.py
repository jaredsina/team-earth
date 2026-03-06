
#cases = int(sys.stdin.readline().rstrip())
#for caseNum in range(cases):
   #line = sys.stdin.readline().rstrip()
#for caseNum in range(cases):
    #line = sys.stdin.readline().rstrip()
#splitValues = line.split(" ")
#player1 = []
#player2 = []
#player1.append(int(cards[0]))
#player1.append(int(cards[1]))
#player1.append(int(cards[2]))
#player2.append(int(cards[3]))
#player2.append(int(cards[4]))
#player2.append(int(cards[5]))
#player1.sort()
#player2.sort()
#num1 = (player1[2] * 10) + player1[1]
#num2 = (player2[2] * 10) + player2[1]
#if num1 == num2:
#	print("WAR!")
#elif num1 > num2:
#	print("PLAYER 1")
#else:
#	print(  "PLAYER 2")
			
import sys 
import string
cases = int(sys.stdin.readline().rstrip())
for _ in range(cases):
    line = sys.stdin.readline().rstrip()
    cards = line.split(" ")
#list 
bigNum = cards[0:3]
print(bigNum)
bigNumm = cards[3:6]
print(bigNumm)
first = 0
second = 0
for number in bigNum:
    x = int(number)
    if x > first:
        second = first
        x = first
        print(first)
#new big num = 2 big num, 
