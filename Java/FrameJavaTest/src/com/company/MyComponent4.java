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
public class MyComponent4 extends JComponent implements MouseMotionListener,ActionListener, Runnable {
    private String message;
    int messageX = 125, messageY = 95;
    JButton theButton;
    int colorIndex;
    static Color[] someColors = {Color.black, Color.red, Color.blue, Color.green, Color.magenta};
    boolean blinkState;

    public MyComponent4(String message){
        this.message = message;
        this.theButton = new JButton("Change color");
        setLayout(new FlowLayout());                     //размещает кнопку поцентру вверху фрэйма
        add(theButton);
        theButton.addActionListener(this);
        addMouseMotionListener(this);
        Thread t = new Thread(this);                     //работа с потоками, запускает метод run() при запуске программы
        t.start();
    }

    public void paintComponent(Graphics g){
        g.setColor(blinkState ? getBackground():currentColor());
        g.drawString(message, messageX, messageY);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == theButton)changeColor();
    }

    @Override
    public void mouseDragged(MouseEvent e) {
        messageX = e.getX();
        messageY = e.getY();
        repaint();
    }

    @Override
    public void mouseMoved(MouseEvent e) {

    }

    @Override
    public void run() {                                 //тут происходит мигание текста
        try{
            while (true) {
                blinkState = !blinkState;
                repaint();
                Thread.sleep(50);
            }
        }

        catch (InterruptedException ie){}
    }

    synchronized private void changeColor() {                     //synchronized выполняет потоки
        if (++colorIndex == someColors.length) colorIndex = 0;
        setForeground(currentColor());                           //изменяем цвет, которым рисуется текст в программе
        repaint();
    }

    synchronized private Color currentColor() {
        return someColors[colorIndex];
    }
}
