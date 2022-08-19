int firstfFiendSpeed = 1;
int secondFriendspeed = 2;
int dogSpeed = 5;
int distance = 10000;
int friend = 2;
int count = 0;
while(distance > 10) 
    {
        if( friend == 1 )
        {
            int time = distance / (firstfFiendSpeed + dogSpeed);
            friend = 1;
            distance = distance - (firstfFiendSpeed + secondFriendspeed)*time;
        }
        else
        {
            int time = distance / (secondFriendspeed + dogSpeed);
            distance = distance - (firstfFiendSpeed + secondFriendspeed)*time;    
        }

    count = count + 1;
    }
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");