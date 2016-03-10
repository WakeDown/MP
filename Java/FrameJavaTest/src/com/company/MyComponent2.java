package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

/**
 * Created by trefi on 18.12.2015.
 */
public class MyComponent2 extends JComponent implements MouseMotionListener {
    private String message;
    int messageX = 125, messageY = 95;

    public MyComponent2(String message){
        this.message = message;
        addMouseMotionListener(this);
    }
    public void paintComponent(Graphics g){
        g.drawString(message, messageX, messageY);
    }

    @Override
    public void mouseDragged(MouseEvent e) {               // Метод, разрешающий передвигать объект, при зажатии и передвишения мыши
        messageX = e.getX();     //текущее положение мыши;  // Важно зажатие мыши
        messageY = e.getY();
        repaint();                //перерисовка message
    }

    @Override
    public void mouseMoved(MouseEvent e) {      // Не важно зажата мышь или нет
        //messageX = e.getX();
        //messageY = e.getY();
        //repaint();
    }
}
/*
MouseEvent - действия связанный с мышкой
KeyEvent - клавиатура
ActionEvent -


 */