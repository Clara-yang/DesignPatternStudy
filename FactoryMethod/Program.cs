// See https://aka.ms/new-console-template for more information

using FactoryMethod;

IFactory studentFactory = new CollegeStudentFactory();
LeiFeng student = studentFactory.CreateLeiFeng();
student.Sweep();
student.Wash();

IFactory volunteerFactory = new VolunteerFactory();
LeiFeng volunteer = volunteerFactory.CreateLeiFeng();
volunteer.Sweep();
volunteer.Wash();
volunteer.BuyRice();
 
