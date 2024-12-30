namespace StudentApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            //StudentApp.Banking.BankAccount ba;
            // ba = new Banking.BankAccount();

            //Console.WriteLine("Currrent Balance " + ba.cbalance);

            //Console.WriteLine("Enter Amount to Deposit :");
            //double DepositAmount = Convert.ToDouble( Console.ReadLine());
            //ba.Deposit(DepositAmount);

            //Console.WriteLine("After Depositing {0} current Balance :{1} ",DepositAmount, ba.cbalance);

            //Console.WriteLine("Enter Amount to Withdraw :");
            //double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            //ba.Withdraw(withdrawAmount);
            //Console.WriteLine("After Withdrawing "+ withdrawAmount +" current balance is " + ba.cbalance);
            //Console.ReadKey();
            //Console.WriteLine("---------------------------------------------------------------------");

            //Console.WriteLine("Hy Enter the First Name :");
            //String firstName = Console.ReadLine();
            //Console.WriteLine("Hy Enter the Last Name :");
            //String lastName = Console.ReadLine();
            //Console.WriteLine("Hy Enter the City :");
            //String City = Console.ReadLine();
            //Console.WriteLine(" {0} {1} is coming from {2}",firstName,lastName,City);
            //Console.WriteLine("Name:"+ firstName+" "+lastName);
            //Console.WriteLine("City :"+City);
            //Console.WriteLine("---------------------------------------------------------------------");

            // Console.WriteLine("Student Apllication Management System");
            // Student s1 = new Student();
            // s1.rollno = Student.incrementId();
            // s1.sname = "chiku";
            // s1.gender = 'M';

            // /*Console.WriteLine("Roll No :" + s1.rollno);
            // Console.WriteLine("Name:" + s1.sname);
            // Console.WriteLine("Gender :" + s1.gender);*/
            // s1.displayDetails(sname:s1.sname,gender:s1.gender,rollno:s1.rollno);
            // Student s2 = new Student();
            // s2.rollno = Student.incrementId();
            // s2.sname = "Priya";
            // s2.gender = 'F';
            ///* Console.WriteLine("Roll No :" + s2.rollno);
            // Console.WriteLine("Name:" + s2.sname);
            // Console.WriteLine("Gender :" + s2.gender);*/
            //s2.displayDetails(sname:s2.sname,gender:s2.gender);
            // Console.ReadKey();

            //Console.WriteLine("Student Apllication using Interface");
            //Student s1 = new Student();
            //s1.rollno = Student.incrementId();
            //s1.pname = "chiku";
            //s1.gender = 'M';
            //s1.City = "Pune";
            //s1.State = "Mumbai";
            //s1.ZipCode = 605322;
            //s1.mobile = 9790160731;
            //s1.emailId = "dharun123@gmail.com";
            //s1.showDetails();
            //Console.WriteLine ( s1.getAddress());
            //s1.showContact();

            //Console.WriteLine("--------------------------------------------------------------------");

            //Faculty f1 = new Faculty();
            //f1.pname = "Dhanush";
            //f1.gender = 'M';
            //f1.City = "Chennai";
            //f1.State = "Tamil Nadu";
            //f1.ZipCode = 612212;
            //f1.mobile = 9790468391;
            //f1.emailId = "dhanush123@gmail.com";
            //f1.showDetails();
            //Console.WriteLine(f1.getAddress());
            //f1.showContact();
            //Console.WriteLine("---------------------------------------------------------------------");

            //StringFunction strf = new StringFunction();
            //strf.ShowStringFunction();

            //fruits strReplace = new fruits();
            //strReplace.ShowStringReplace();

            //fruits strcount = new fruits();
            //strcount.Stringcount();

            //math math = new math();
            //math.mathematicFunction();

            //DateTimeMethod dtm = new DateTimeMethod();
            //dtm.DateTimeFunction();

            //Arayfunction arrf = new Arayfunction();
            //arrf.Arrayfunction();

            //ArrayTask arrayTask = new ArrayTask();
            //arrayTask.showArraySearch();

            //ArrayTask arrayTask1 = new ArrayTask();
            //arrayTask1.showArraySearch2();

            //ArrayTask frt = new ArrayTask();
            //frt.showArrayfruits();

            //fruitstask frtstsk = new fruitstask();
            //frtstsk.displayfruits();

            //fruitstask ftr = new fruitstask();
            //ftr.menubar();

            //List lt = new List();
            //lt.showList();

            ListTask lst = new ListTask();
            lst.listmenubar();

            Console.ReadKey();

        }
    }
}