package DrawingPyramid;

import java.awt.Graphics;

public class Rectangle implements Shape{

    private int length;
    private int width;
    private int x = 250;
    private int y = 50;
    private int bricks;

    public Rectangle(int length, int width,int bricks) {
        this.length = length;
        this.width = width;
        this.bricks = bricks;
    }

    @Override
    public void draw(Graphics g) {
        int j=1, nr = 0;
        while(nr < bricks && bricks - nr >= j) {
        for(int i=0;i<j;i++) {
        	g.drawRect(x-j*width/2+i*width,y+j*length, width, length);
        	nr++;
        }
        j++;
        }
        System.out.println("Number of unused bricks is: "+(bricks-nr));
    }
}