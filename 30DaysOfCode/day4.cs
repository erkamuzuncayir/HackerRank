// Day 4: Class vs. Instance 

class Person {
    public int age;     
	public Person(int initialAge) {
        if(initialAge < 0)
    {
        age = 0;
        Console.WriteLine("Age is not valid, setting age to 0.");
    }
        else if(0 < initialAge)
        {
        age = initialAge;
        }
     }
     public void amIOld() {
        if(age < 13)
        {
                Console.WriteLine("You are young.");
        }
        else if((13 <= age) && (age < 18))
        {
                Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are old.");
        }
        
     }

     public void yearPasses() {
        age += 1;
     }

