n1=0
n2=0
n3=0
n4=0
n5=0

repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to breakout room 3"
echo "We are selling brand shoes "
echo "What brand would you like to buy"
echo "Please choose number for which brand you would like to buy"
echo "1. Nike"
echo "2. Yeezy"
echo "3. Puma"
echo "4. Adidas"
echo "5. Jordan"

read answer1

if [ "$answer1" == "1" ]
then	
	n1=70
	echo "Your Nike purchase is going to be $n1 U.S Dollars"
	echo "Would you like to buy something else?"
	echo "press 1 if Yes press 2 to checkout"
	read answer11
elif [ "$answer11" == "1" ]
then
	repeat="true"
fi

if  [ "$answer1" == "2" ]
then
	n2=400
	echo "Your Yeezy purchase is going to be $n2 U.S Dollars"
	echo "Would you like to buy something else?"
        echo "press 1 if Yes press 2 to checkout"
	read answer11
elif [ "$answer11" == "1" ]
then
	repeat="true"

fi

if [ "$answer1" == "3" ]
then
	n3=150
	echo "Your Puma purchase is going to be $n3 U.S Dollars"
	echo "Would you like to buy something else?"
        echo "press 1 if Yes press 2 to checkout"
        read answer11
elif [ "$answer11" == "1" ]
then
        repeat="true"

fi

if [ "$answer1" == "4" ]
then
	n4=250
	echo "Your Adidas purchase is going to be $n4 U.S Dollars"
	echo "Would you like to buy something else?"
        echo "press 1 if Yes press 2 to checkout"
        read answer11
elif [ "$answer11" == "1" ]
then
        repeat="true"

fi

if [ "$answer1" == "5" ]
then
	n5=450
	echo "Your Jordan purchase is going to be $n5 U.S Dollars"
	echo "Would you like to buy something else?"
        echo "press 1 if Yes press 2 to checkout"
        read answer11
elif [ "$answer11" == "1" ]
then
        repeat="true"

fi

if [ "$answer11" == "2" ]
then
	echo "Your total purchase is going to be $(($n1+$n2+$n3+$n4+$n5))"
	echo "Press 1 to pay press 2 keep buying"
	read answer111
elif [ "$answer111" == "2" ]
then
	repeat="true"
fi

if [ "$answer111" == "1" ]
then
	repeat="false"
fi

done
