using Newtonsoft.Json;
using Wema.BIT.IRepository;
using Wema.BIT.IRepository.Repository;
using Wema.BIT.Models;
using static Wema.BIT.Models.AreaOfTraingle;

namespace Wema.BIT.User
{
    public class User
    {

        private readonly IUsers _u;
        private readonly IUsers _context;
        private static int num = 0;

        public User(IUsers u, IUsers context)
        {
            _u = u;
            _context = context;

            num = _u.AddNumber(21, 55);
        }


        public static void Main(String[] args)
        {
            UserRepository contextt = new UserRepository();
            var usr = new UsersList
            {
                Email = "johndoe@email.com",
                First_Name = "John",
            };
            contextt.AddUser(usr);


            Console.WriteLine("List of Users:");

            var allUser = contextt.GetAllUsers();
            DisplayUsers(allUser);


            static void DisplayUsers(List<UsersList> users)
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"Name: {user.First_Name} {user.Last_Name}, Email: {user.Email}");
                }

                // Console.WriteLine(uu.AddNumber(23, 55));
                Console.WriteLine(num);


                /* Transaction pm = new Transaction ();

                var sumOfAb = pm.addPayment();
                 var mn = pm.myName;
                 var c = Transaction.myStaticName;

                 Console.WriteLine(sumOfAb);
                 Console.WriteLine(mn);
                 Console.WriteLine(c);*/


                /*   List<String> Name = new List<String> ();
                   Name.Add("Ade");
                   Name.Add("Ade");
                   Name.Add("Ade");

                   var studentName = new string[6] { "jide", "Tbams", "Tolu", "Joseph", "Luke", "Rita" };


                   Console.WriteLine("\n");
                   Console.WriteLine("using for loop");
                   for (int i = 0; i < studentName.Length; i++)
                   {
                       Console.WriteLine(studentName[i]);
                   }
                   Console.WriteLine("\n");
                   Console.WriteLine("using foreach loop");

                   foreach (string counter in studentName) 
                   {
                       Console.WriteLine(counter); 
                   }*/

                /* Triangle myTriangle = new Triangle();

                 Input base and height values
                 Console.WriteLine("Enter the base of the triangle:");
                 myTriangle.Base = Convert.ToDouble(Console.ReadLine());

                 Console.WriteLine("Enter the height of the triangle:");
                 myTriangle.Height = Convert.ToDouble(Console.ReadLine());

                 Calculate and display the area
                 double area = myTriangle.CalculateArea();
                 Console.WriteLine($"The area of the triangle is: {area}");
     */

                /*  List<Transaction> transactions = new List<Transaction>()
                  {
                     new Transaction() {UserID = 1, PaymentId= 1, Payment_amount=126725},
                     new Transaction() {UserID = 2, PaymentId= 1, Payment_amount=10325},
                     new Transaction() {UserID = 3, PaymentId= 1, Payment_amount=78325}

                  };


                  List<UsersList> usersLists = new List<UsersList>()
                  {
                      new UsersList() {Id = 1, Email="faisal007@gmail.com", First_Name="Faisal",Last_Name="Ozigis", Transactions=transactions.Where(x => x.UserID == 1).ToList()},
                      new UsersList() {Id = 2, Email="Tolu001@gmial.com", First_Name="Tolu",Last_Name="Akintayo", Transactions=transactions.Where(x => x.UserID == 2).ToList()},
                      new UsersList() {Id = 3, Email="Emmaunelk@gmail.com", First_Name="Emmanuel",Last_Name="Kayode", Transactions=transactions.Where(x => x.UserID == 3).ToList()},
                      new UsersList() {Id = 4, Email="Timmy1323@gmail.com", First_Name="Timmy",Last_Name="Egbe", Transactions=transactions.Where(x => x.UserID == 4).ToList()},
                      new UsersList() {Id = 5, Email="Uche1323@gmail.com", First_Name="Uchennna",Last_Name="Morris", Transactions=transactions.Where(x => x.UserID == 5).ToList()}
                  };

                  var userTransaction = usersLists.Where(x => x.Id == 1);
                  var u = new List<User>();

                  var josn = JsonConvert.SerializeObject(userTransaction,Formatting.Indented);

                  Console.WriteLine("\n");
                  Console.WriteLine("using foreach loop");
                  foreach (var users in usersLists)
                  {
                      if (users.First_Name == "Timmy" && users.Last_Name == "Egbe")
                          Console.WriteLine("First Name : " + users.First_Name + " Last Name : " + users.Last_Name); 
                  }

                  for (int i = 0; i < usersLists.Count; i++)
                {
                    *//* Console.WriteLine("User Details:");
                     Console.WriteLine("Id: " + usersLists[i].Id + ", First Name: " + usersLists[i].First_Name + ", Last Name: " + usersLists[i].Last_Name + ", Email: " + usersLists[i].Email);

                     Console.WriteLine("Payments for User " + usersLists[i].Id + ":");
                     foreach (var payment in payments)
                     {
                         if (payment.UserID == usersLists[i].Id)
                         {
                             Console.WriteLine("PaymentId: " + payment.PaymentId + ", Payment Amount: " + payment.Payment_amount);
                         }
                     }
                     Console.WriteLine();*//*

                 }*/

                //Console.write("Enter a number: ");
                //   int num1 = Convert.ToInt32(Console.ReadLine());

                //  Console.write("Enter another number: ");
                //  int num2 = Convert.ToInt32(Console.ReadLine());

                // Console.writeLine(num1 + num2);

                //  Console.Readline();


            }
        }
    }
}
    //public class Payment
    //{
       // public static void Greet()
       //{
         //   Console.WriteLine("Good Afternoon");
        //}

       // public string GreetMe()
      //{
       //    Console.WriteLine("Good Afternoon");

        //   return "Good Afternoon";
      //  }
   //}
//}


