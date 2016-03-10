package com.company;

import java.sql.*;

public class Main {

    public static void main(String[] args) throws ClassNotFoundException{
        Class.forName("com.mysql.jdbc.Driver");
        Statement statement = null;

        try {
            Connection connection =
                    DriverManager.getConnection("jdbc:mysql://localhost/mydb?user=root&password=30051996Ad");

            statement = connection.createStatement();
            ResultSet resultSet;
            resultSet = statement.executeQuery("SELECT * FROM student");

            while (resultSet.next()){
                System.out.println(resultSet.getString("name"));
                System.out.println(resultSet.getInt("age"));
            }

            PreparedStatement statement2 = connection.prepareStatement("SELECT * FROM student");
            statement2.setInt(1, 2);
            statement2.setInt(2, 19);
            statement2.execute("DELETE FROM student where idstudent=? AND age < ?");
        }
        catch (SQLException sqlEx){
            sqlEx.printStackTrace();
        }
        finally {
            if (statement != null){
                try {
                    statement.close();
                } catch (SQLException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}
