package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

/**
 * Created by trefi on 18.12.2015.
 */
public class MyComponent3 extends JComponent implements MouseMotionListener,ActionListener {
    private String message;
    int messageX = 125, messageY = 95;
    JButton theButton;
    int colorIndex;
    static Color[] someColors = {Color.black, Color.red, Color.blue, Color.green, Color.magenta};

    public MyComponent3(String message){
        this.message = message;
        this.theButton = new JButton("Change color");
        setLayout(new FlowLayout());                     //размещает кнопку поцентру вверху фрэйма
        add(theButton);
        theButton.addActionListener(this);
        addMouseMotionListener(this);
    }
    public void paintComponent(Graphics g){
        g.drawString(message, messageX, messageY);
    }

    @Override
    public void mouseDragged(MouseEvent e) {}

    @Override
    public void mouseMoved(MouseEvent e) {
        messageX = e.getX();
        messageY = e.getY();
        repaint();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == theButton)changeColor();
    }

    synchronized private void changeColor() {                     //synchronized упорядычивает методы
        if (++colorIndex == someColors.length) colorIndex = 0;
        setForeground(currentColor());                           //изменяем цвет, которым рисуется текст в программе
        repaint();
    }

    private Color currentColor() {
        return someColors[colorIndex];
    }
}