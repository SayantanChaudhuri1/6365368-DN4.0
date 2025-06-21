package MVCPattern;

public class Main {
    public static void main(String[] args) 
    {
        Student student = new Student("Sayantan", "6365368", "A");
        StudentView view = new StudentView();
        StudentController controller = new StudentController(student, view);
        System.out.println("Initial Student Info:");
        controller.updateView();
        controller.setStudentName("Sayantan Chaudhuri");
        controller.setStudentGrade("A+");

        System.out.println("\nUpdated Student Info:");
        controller.updateView();
    }
}
