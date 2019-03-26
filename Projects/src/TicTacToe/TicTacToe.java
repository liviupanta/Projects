package TicTacToe;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

public class TicTacToe extends JFrame implements ActionListener{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	int x=0, y=0;
	int counter = 9;
	String lit = null;
	JButton cas1;
	JButton cas2;
	JButton cas3;
	JButton cas4;
	JButton cas5;
	JButton cas6;
	JButton cas7;
	JButton cas8;
	JButton cas9;
	JTextField player1;
	JTextField player2;
	JOptionPane winner;
	
	TicTacToe(){
		setTitle("TicTacToe Game");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		init();
		setSize(280,340);
		setVisible(true);
		setResizable(false);

	}
	
	public void init() {
		
		int width = 50, height = 50;
		this.setLayout(null);
		
		cas1 = new JButton();
		cas1.setBounds(50, 30, width, height);
		cas1.addActionListener(this);
		
		cas2 = new JButton();
		cas2.setBounds(110, 30, width, height);
		cas2.addActionListener(this);
		
		cas3 = new JButton();
		cas3.setBounds(170, 30, width, height);
		cas3.addActionListener(this);
		
		cas4 = new JButton();
		cas4.setBounds(50, 90, width, height);
		cas4.addActionListener(this);
		
		cas5 = new JButton();
		cas5.setBounds(110, 90, width, height);
		cas5.addActionListener(this);
		
		cas6 = new JButton();
		cas6.setBounds(170, 90, width, height);
		cas6.addActionListener(this);
		
		cas7 = new JButton();
		cas7.setBounds(50, 150, width, height);
		cas7.addActionListener(this);
		
		cas8 = new JButton();
		cas8.setBounds(110, 150, width, height);
		cas8.addActionListener(this);
		
		cas9 = new JButton();
		cas9.setBounds(170, 150, width, height);
		cas9.addActionListener(this);
		
		player1 = new JTextField(" Player1:   " +x);
		player1.setBounds(60, 250, 70, 30);
		player1.setEnabled(false);
		
		player2 = new JTextField(" Player2:   " +y);
		player2.setBounds(140, 250, 70, 30);
		player2.setEnabled(false);
		
		add(cas1); add(cas2); add(cas3); add(cas4);
		add(cas5); add(cas6); add(cas7); add(cas8); add(cas9); add(player1); add(player2);
	}
	
	public void checkWin() {
		
		if(cas1.getText().equals(cas2.getText()) && cas1.getText().equals(cas3.getText()) && cas1.getText() == "X") {
			x++;
			player1.setText(" Player1:   " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas1.getText().equals(cas2.getText()) && cas1.getText().equals(cas3.getText()) && cas1.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas1.getText().equals(cas4.getText()) && cas1.getText().equals(cas7.getText()) && cas1.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas1.getText().equals(cas4.getText()) && cas1.getText().equals(cas7.getText()) && cas1.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas4.getText().equals(cas5.getText()) && cas4.getText().equals(cas6.getText()) && cas4.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas4.getText().equals(cas5.getText()) && cas4.getText().equals(cas6.getText()) && cas4.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas7.getText().equals(cas8.getText()) && cas7.getText().equals(cas9.getText()) && cas7.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas7.getText().equals(cas8.getText()) && cas7.getText().equals(cas9.getText()) && cas7.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas2.getText().equals(cas5.getText()) && cas2.getText().equals(cas8.getText()) && cas2.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas2.getText().equals(cas5.getText()) && cas2.getText().equals(cas8.getText()) && cas2.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas3.getText().equals(cas6.getText()) && cas3.getText().equals(cas9.getText()) && cas3.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas3.getText().equals(cas6.getText()) && cas3.getText().equals(cas9.getText()) && cas3.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas1.getText().equals(cas5.getText()) && cas1.getText().equals(cas9.getText()) && cas1.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas1.getText().equals(cas5.getText()) && cas1.getText().equals(cas9.getText()) && cas1.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		} else if(cas3.getText().equals(cas5.getText()) && cas3.getText().equals(cas7.getText()) && cas3.getText() == "X") {
			x++;
			player1.setText(" Player:    " +x);
			JOptionPane.showMessageDialog(null, "Player1 win!");
			dispose();
		} else if(cas1.getText().equals(cas5.getText()) && cas3.getText().equals(cas7.getText()) && cas3.getText() == "O") {
			y++;
			player2.setText(" Player2:   " +y);
			JOptionPane.showMessageDialog(null, "Player2 win!");
			dispose();
		}
	}
	@Override
	public void actionPerformed(ActionEvent a) {
		
			if(counter%2 == 1)
				lit = "X";
			else
				lit = "O";
			
			if(a.getSource() == cas1) {
				cas1.setText(lit);
				cas1.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas2) {
				cas2.setText(lit);
				cas2.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas3) {
				cas3.setText(lit);
				cas3.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas4) {
				cas4.setText(lit);
				cas4.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas5) {
				cas5.setText(lit);
				cas5.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas6) {
				cas6.setText(lit);
				cas6.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas7) {
				cas7.setText(lit);
				cas7.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas8) {
				cas8.setText(lit);
				cas8.setEnabled(false);
				counter--;
				checkWin();
			} else if(a.getSource() == cas9) {
				cas9.setText(lit);
				cas9.setEnabled(false);
				counter--;
				checkWin();
			}
			
			if(counter == 0) {
				
				JOptionPane.showMessageDialog(null, "No player wins! TRY AGAIN!");
				dispose();
			}
		
	}
	
	public static void main(String[] args) {
		
		new TicTacToe();
	}
}