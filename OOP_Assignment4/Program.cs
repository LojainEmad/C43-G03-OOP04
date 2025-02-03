using OOP_Assignment4.Calc_Project;

using OOP_Assignment4.Notification_Project;
using OOP_Assignment4.Point_Project;
using OOP_Assignment4.Security_Module;
using OOP_Assignment4.Shape_Project;


namespace OOP_Assignment4
{
    internal class Program
    {
        #region Function to test Question3 

        static void SendNotification(INotificationService notificationService)           //Develop against interface
        {
            notificationService.SendNotification("Lojain", "Please give me Response");
        }

        #endregion
       



        static void Main(string[] args)
        {

            #region Question1
            //Circle circle = new Circle();
            //circle.Radius = 5;
            //circle.DispalyShapeInfo();
            //Rectangle rec = new Rectangle();
            //rec.Width = 10;
            //rec.Height = 5;
            //rec.DispalyShapeInfo();


            #endregion

            #region Question2
            //IAuthenticationService authSerive = new BasicAuthenticationService();
            //bool IsAuth = authSerive.AuthenticateUser("LojainEmad", "1234");
            //bool IsAuthorized = authSerive.AuthorizeUser("LojainEmad", "Admin");
            //Console.WriteLine($"User is Authenticated ?{IsAuth}");   //true
            //Console.WriteLine($"User is AuthenAuthorized?{IsAuthorized}");   //true
            //authSerive = new AdvancedAuthService();
            //IsAuth= authSerive.AuthenticateUser("LojainEmad ", "1234");
            //IsAuth = authSerive.AuthorizeUser("LojainEmad ", "Admin");
            //Console.WriteLine($"User is Authenticated ?{IsAuth}");  //false
            //Console.WriteLine($"User is AuthenAuthorized ?{IsAuth}");  //false

            #endregion

            #region Question3
            //INotificationService notificationRef = new EmailNotificationService();
            //notificationRef.SendNotification("Lojain", "Please give me Response");
            //notificationRef = new SmsNotificationService();
            //notificationRef.SendNotification("012345566", "Please give me Response");
            //notificationRef = new PushNotificationService();
            //notificationRef.SendNotification("Lojain", "Please give me Response");
            //--------------------------

            ////here can pass any object which implement interface INotificationService
            //EmailNotificationService emailNotificationService = new EmailNotificationService();         //Develop Against interface
            //SendNotification(emailNotificationService);

            //SmsNotificationService msNotificationService = new SmsNotificationService();
            //SendNotification(msNotificationService);



            #endregion

            #region First Project
            ////Point3D P = new Point3D(10, 10, 10);
            ////Console.WriteLine(P);    //call the overriden toString()


            //Point3D FirstP = Point3D.CreateNewPoint();
            //Console.WriteLine(FirstP);
            //Point3D SecP = Point3D.CreateNewPoint();
            //Console.WriteLine(SecP);
            //Point3D ThirdP = Point3D.CreateNewPoint();
            //Console.WriteLine(ThirdP);

            ////-----------------------------
            ////if (FirstP == SecP)              //--> compare addresses of objs to values
            ////{
            ////    Console.WriteLine("Equals");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("NotEquals");
            ////}

            ////----------------------------
            //if (FirstP.Equals(SecP))              //--> compare values after override
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("NotEquals");
            //}

            //--------------------------------------------------
            //Point3D[] points= Point3D.ArrayPoints(3);   //->Point3D.ArrayPoints(3) will return array of obj of points , receive it in the reference points
            // //----------------------------------
            // //Point3D.PrintPoints(points);
            // ////Array.Sort(points); //give exception as there is 3 coordinates for each point
            // //Point3D.PrintPoints(points);
            // //------------------------------------
            // //Sort function to work with any type of array i made , the class must implemement interface Icomparable 

            // Point3D.PrintPoints(points);
            // Array.Sort(points);
            // Console.WriteLine("Array points after sort ascending ");
            // Point3D.PrintPoints(points);

            //-----------------------------
            //Point3D p1 = new Point3D(7, 5, 3);
            //Point3D p2=(Point3D)p1.Clone();    //-> will have same values
            //Console.WriteLine(p2);
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());    //same addresses as i make override for GetHashCode 
            #endregion

            #region Secound Project
            ////MathsClass maths =new MathsClass();
            //double result = MathsClass.Sum(4, 3);
            //Console.WriteLine(result);
            //result = MathsClass.Subtruct(4, 3);
            //Console.WriteLine(result);
            //result = MathsClass.Multiply(4, 3);
            //Console.WriteLine(result);
            //result = MathsClass.Divide(4, 3);
            //Console.WriteLine(result);
            #endregion

            #region third Project

            #endregion
        }
    }
}
