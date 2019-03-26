package DrawingPyramid;

import javax.swing.*;
import java.awt.*;

public class DrawingBoard  extends JFrame {

    Shape[] shapes = new Shape[10];

    public DrawingBoard() {
        super();
        this.setTitle("Drawing pyramid");
        this.setSize(500,500);
        this.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        this.setVisible(true);
    }

    public void addShape(Shape s1){
        for(int i=0;i<shapes.length;i++){
            if(shapes[i]==null){
                shapes[i] = s1;
                break;
            }
        }
        this.repaint();
    }
    
    public void paint(Graphics g){
        for(int i=0;i<shapes.length;i++){
            if(shapes[i]!=null)
                shapes[i].draw(g);
        }
    }
}