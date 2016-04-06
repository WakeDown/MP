package com.example.AndroidLearning;

import Person.Person;
import android.app.ListActivity;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.*;

/**
 * Класс главного Активити, где мы видим весь список исполнителей
 */

public class MainActivity extends ListActivity {

    protected ArrayList<Person> persons;
    private  CustomList adapter;

     @Override
    public void onCreate(Bundle savedInstanceState) {
         super.onCreate(savedInstanceState);
         persons = new ArrayList<>();
         adapter = new CustomList(this, persons);
         setListAdapter(adapter);
         new ParseTask().execute();
         }


    //Загрузка JSON и присваивание данных новому исполнителю, а затем добавление его в лист
    private class ParseTask extends AsyncTask<Void, Void, String> {

        HttpURLConnection urlConnection = null;
        BufferedReader reader = null;
        String resultJson = "";

        @Override
        protected String doInBackground(Void... params) { //Подключение и чтение
            try {
                URL url = new URL("http://cache-ekt03.cdn.yandex.net/download.cdn.yandex.net/mobilization-2016/artists.json");
                urlConnection = (HttpURLConnection) url.openConnection();
                urlConnection.setRequestMethod("GET");
                urlConnection.connect();
                InputStream inputStream = urlConnection.getInputStream();
                StringBuffer buffer = new StringBuffer();
                reader = new BufferedReader(new InputStreamReader(inputStream));
                String line;
                while ((line = reader.readLine()) != null) {
                    buffer.append(line);
                }
                resultJson = buffer.toString();
            } catch (Exception e) {
                e.printStackTrace();
            }
            return resultJson;
        }

        @Override
        protected void onPostExecute(String strJson) { //Разбор полченной строки
            super.onPostExecute(strJson);

            try {
                JSONArray singers = new JSONArray(strJson);

                for (int i = 0; i < singers.length(); i++) {
                    JSONObject singer = singers.getJSONObject(i);
                    int id = singer.getInt("id");
                    String name = singer.getString("name");
                    int tracks = singer.getInt("tracks");
                    int albums = singer.getInt("albums");


                    JSONArray genresJSON = singer.getJSONArray("genres");
                    String[] generes = new String[genresJSON.length()];
                    for (int j = 0; j < generes.length; j++){
                        generes[j] = genresJSON.getString(j);
                    }

                    String description = singer.getString("description");

                    JSONObject coversJSON = singer.getJSONObject("cover");
                    String[] covers = new String[2];
                    covers[0] = coversJSON.getString("small");
                    covers[1] = coversJSON.getString("big");

                    Person person = new Person(id, name, generes, tracks, albums, description, covers);
                    try{
                        String link = singer.getString("link");
                        person.setLink(link);
                    }catch (Exception ex){}finally {}
                    persons.add(person);
                    adapter.notifyDataSetChanged();  //Обновление адаптера
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
    }
}
