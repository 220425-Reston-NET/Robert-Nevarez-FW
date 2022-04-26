#this is a comment
#It is like putting a sticky note to your code to give a more meaningful 
#message of what you are doing in this script
#Echo is a way for us to give feedback to the person running the shell scripting

echo "This is your first shell script"

#Variable
msg="Hello World Variable"
echo $msg #$ syntax is what we need to write to reference a variable

# control flow
# They are a way to tell the program to run multiple lines of codes multiple 
#times or we can tell the program to lines of codes if a condition is met

#if statements
ten=10
five=5
thirteen=13

echo "===First If==="
if [ "$five" -ge "$ten" ] 
then echo "Greater!" 
echo "$ten > $five"
fi

echo "===Second If==="

if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "Lesser!"
echo "$five < $ten"
fi

echo "===Third If===" 
if [ "$five" -ge "$ten" ] 
then 
echo "Greater!" 
echo "$five > $ten" 
elif [ "$five" -ge "$ten" ] 
then 
echo "Greater!"
else 
echo "Nothing Matches" 
fi

#Loops statement
# A way to repeat multiple lines of code x amount of times you want

#For loops statement
#useful if you know how many times you have to execute those lines of codes
#will repeat x amount of times

echo "===For Loops==="
echo "===First Loop==="

for number in 10 5 world 1 2 
do
echo "Hello $number"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While Loops==="
#While Loop Statement
#will keep running your lines of codes as long as the condition is true
# Useful if you don't know how many times you need to execute those lines of codes

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) #((mathematical operation)) syntax is how we can do math in Shell
done

# Input and Output
#We can ask for input from the user that is using shell scripting and output some sort of response

echo "What is your name?"
read name #read [whatever variable name you specify] will store the user input in that variable

echo "Hello $name, Welcome to programming"

#Making a shell menu
clear #clear will clear all the text in the terminal

repeat="true"
while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting!" 
echo " What do you want to do today?" 
echo "1 for adding two numbers?" 
echo "enter 2 to exit"
read answer
if [ "$answer" == "1" ]
then
	echo "Give me number 1"
	read num1
	echo "Give me number 2"
	read num2
	echo "The sum is $(($num1+$num2))"
elif [ "$answer" == "2" ]
then
	repeat="false"
else
	echo "Enter a correct option"
fi
done

#This message is to modify git commit
#Stephen Code
