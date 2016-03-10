package com.company;

import javax.swing.*;

public class Main {

    public static void main(String[] args) {
        JFrame frame = new JFrame("First Frame");                   //создаем фрэйм и подписываем
        //JLabel label = new JLabel("Hello, User!", JLabel.CENTER);   //Создаем лэйбл, пишем в него текст и размещаем по центру
        //frame.add(label);                                           //Добавляем лэйбл во фрэйм

        //frame.add(new MyComponent());                                //Рисует лэйбл с помощью метода класса

        //frame.add(new MyComponent2("Hallo class with message!"));    //Рисует сообщение с помощью класса

        //frame.add(new MyComponent3("Color Label"));                   //кнопка, которая меняет цвет сообщения сообщения

        frame.add(new MyComponent4("Party Hard!"));                    //все выше сделанное, но надпись мегает

        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);        //при закрытии фрэйма завершает раюоту программы

        frame.setSize(300, 300);                                    //задаем размер фрэйму
        frame.setVisible(true);                                     //отображаем фрэйм
    }
}
