package com.mygdx.game;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

/**
 * Created by trefi on 13.02.2016.
 */
public class GameFon {
    private float yUp;
    private float yDown;
    private float vY;

    private static Texture fonTexture;

    GameFon (float y, float vY){
        this.yDown = y;
        this.yUp = yDown + Gdx.graphics.getHeight();
        this.vY = vY;
        fonTexture = new Texture("Fon.jpg");
    }

    public void render(SpriteBatch batch){
        batch.draw(fonTexture, 0, yDown);
        batch.draw(fonTexture, 0, yUp);
    }

    public void update(){
        yDown -= vY;
        yUp -= vY;
        transferPictures();
    }

    void transferPictures(){
        if (yDown < -fonTexture.getHeight()) yDown = yUp + fonTexture.getHeight();
        if (yUp < -fonTexture.getHeight()) yUp = yDown + fonTexture.getHeight();
    }
}
