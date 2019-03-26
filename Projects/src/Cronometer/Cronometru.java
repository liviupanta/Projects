package Cronometer;

import javax.swing.*;

import java.awt.event.*;
import java.awt.*;
import java.text.DecimalFormat;
import java.util.concurrent.*;

public class Cronometru extends JFrame 
{

    private static final long serialVersionUID = 2L;

    // GUI Components
    private JPanel panel;
    private JLabel timeLabel;

    private JPanel buttonPanel;
    private JButton startButton;
    private JButton resetButton;
    private JButton stopButton;

    // Properties of Program.
    private byte centiseconds = 0;
    private byte seconds = 0;
    private short minutes = 0;

    private Runnable timeTask;
    private Runnable incrementTimeTask;
    private Runnable setTimeTask;
    private DecimalFormat timeFormatter;
    private boolean timerIsRunning = true;

    private ExecutorService executor = Executors.newCachedThreadPool();

    public Cronometru()
    {
        panel = new JPanel();
        panel.setLayout(new BorderLayout());

        timeLabel = new JLabel();
        timeLabel.setFont(new Font("Consolas", Font.PLAIN, 13));
        timeLabel.setHorizontalAlignment(JLabel.CENTER);
        panel.add(timeLabel);


        buttonPanel = new JPanel();
        buttonPanel.setLayout(new FlowLayout(FlowLayout.CENTER));

        startButton = new JButton("Start");
        startButton.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e)
            {
                if (!timerIsRunning)
                    timerIsRunning = true;

                executor.execute(timeTask);
            }
        });
        buttonPanel.add(startButton);

        resetButton = new JButton("Reset");
        resetButton.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e)
            {
                timerIsRunning = false;

                centiseconds = 0;
                seconds = 0;
                minutes = 0;

                timeLabel.setText(timeFormatter.format(minutes) + ":" 
                        + timeFormatter.format(seconds) + "." 
                        + timeFormatter.format(centiseconds));
            }
        });

        buttonPanel.add(resetButton);

        stopButton = new JButton("Stop");
        stopButton.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e)
            {
                timerIsRunning = false;
            }
        });

        buttonPanel.add(stopButton);


        panel.add(buttonPanel, BorderLayout.SOUTH);


        timeFormatter = new DecimalFormat("00");

        timeTask = new Runnable(){
            public void run()
            {
                while(timerIsRunning)
                {
                    executor.execute(incrementTimeTask);

                    try
                    {
                        Thread.sleep(10);
                    }
                    catch (InterruptedException ex)
                    {
                        ex.printStackTrace();
                    }
                 }
            }
        };

        incrementTimeTask = new Runnable(){
            public void run()
            {
                if (centiseconds < 99)
                    centiseconds++;
                else
                {  if (centiseconds >= 99)
                    {
                        seconds++;
                        centiseconds = 00;
                    }
                    if (seconds == 60)
                    {
                        minutes++;
                        seconds = 0;
                        centiseconds = 00;
                    }
                }

                executor.execute(setTimeTask);
            }
        };

        setTimeTask = new Runnable(){
            public void run()
            {
                timeLabel.setText(timeFormatter.format(minutes) + ":" 
                        + timeFormatter.format(seconds) + "." 
                        + timeFormatter.format(centiseconds));
            }
        };

        timeLabel.setText(timeFormatter.format(minutes) + ":" 
                + timeFormatter.format(seconds) + "." 
                + timeFormatter.format(centiseconds));

        add(panel);

        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setTitle("Cronometru.java");

        pack();
        setVisible(true);
    }

    public static void main(String[] args) 
    {
        new Cronometru();
    }
}