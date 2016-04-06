package com.example.AndroidLearning;

import Person.Person;
import android.app.Activity;
import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

/**
 * Created by trefi on 05.04.2016.
 * Класс для Активити с подробной информацией о выбраном певце
 */
public class PersonInfoActivity extends Activity {

    private TextView genres, tracksAndAlbums, description;
    ImageView avatar;
    private Person singer;

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.person_info);
        singer = Person.selectedPerson;
        initDataAboutSinger();
    }

    // Настройка текстов и картинки, полученных от выбранного испонителя
    private void initDataAboutSinger() {
        setTitle(singer.getName());

        genres = (TextView) findViewById(R.id.genres);
        String genversText = "";
        for (int i = 0; i < singer.getGenres().length; i++){
            genversText += (singer.getGenres()[i] + " ");
        }
        genres.setText(genversText);

        tracksAndAlbums = (TextView) findViewById(R.id.albumsAndTracks);
        String tracksAndAlbumsText = "Альбомов: " + singer.getAlbums() + " Треков: " + singer.getTracks();
        tracksAndAlbums.setText(tracksAndAlbumsText);

        description = (TextView) findViewById(R.id.biographi);
        String descriptionText = singer.getDescription();
        description.setText(descriptionText);

        avatar = (ImageView) findViewById(R.id.bigCover);
        new Person.DownLoadImageTask(avatar).execute(singer.getCovers()[1]);
    }
}
