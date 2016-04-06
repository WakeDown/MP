package com.example.AndroidLearning;

import Person.Person;
import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;
import java.util.ArrayList;

/**
 * Created by trefi on 02.04.2016.
 * Вьюшки в главном Активити
 */
public class CustomList extends BaseAdapter {

    private LayoutInflater inflater;
    private ArrayList<Person> persons;
    Context context;
    private Person item;

    public CustomList(Context context, ArrayList<Person> persons) {
        this.context = context;
        inflater = (LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        this.persons = persons;
    }

    @Override
    public int getCount() {
        return persons.size();
    }

    @Override
    public Object getItem(int position) {
        return persons.get(position);
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        View view = convertView;
        if (convertView == null){
            view = inflater.inflate(R.layout.main, null);
        }
        item = persons.get(position);
        ImageView imageView = (ImageView) view.findViewById(R.id.imAvatar);   //Аватарка исполнителя
        TextView name = (TextView) view.findViewById(R.id.tvName);            //Имя исполнителя
        TextView genvers = (TextView) view.findViewById(R.id.tvGenres);       //Подстрока с данными исполнителя
        view.setOnClickListener(new View.OnClickListener() {                  //Обработка клика
            @Override
            public void onClick(View v) {
                Person.selectedPerson = persons.get(position);
                Intent intent = new Intent(context, PersonInfoActivity.class);
                context.startActivity(intent);
            }
        });
        new Person.DownLoadImageTask(imageView).execute(item.getCovers()[0]);
        name.setText(item.getName());
        String genversText = "";
        for (int i = 0; i < item.getGenres().length; i++){
            genversText += (item.getGenres()[i] + " ");
        }
        genversText += "\n\n\n\n\n" + "Альбомов: " + item.getAlbums() + "  Треков: " + item.getTracks();
        genvers.setText(genversText);

        return view;
    }

}
