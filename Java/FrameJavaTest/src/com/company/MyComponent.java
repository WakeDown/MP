package com.company;

import javax.swing.*;
import java.awt.*;

/**
 * Created by trefi on 18.12.2015.
 */
public class MyComponent extends JComponent {
    public void paintComponent(Graphics g){
        g.drawString("Hello, Component!", 150, 150);
    }
}
