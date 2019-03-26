package DrawingPyramid;

import java.util.Scanner;

public class BuildPyramid {

	public static void main(String[] args) {
		System.out.print("Enter number of bricks: ");
		Scanner in = new Scanner(System.in);
		int num = in.nextInt();
		in.close();
		DrawingBoard p1 = new DrawingBoard();
        Shape s1 = new Rectangle(20,50,num);
        p1.addShape(s1);
	}
}
