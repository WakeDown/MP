package com.mygdx.game;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

/**
 * Created by trefi on 13.02.2016.
 */
public class Asteroids {
    private final float START_Y = Gdx.graphics.getHeight() + 50;
    private float x;
    private float y;
    private float vY;

    private static Texture asteroidTexture;

    public Asteroids() {
        random();
        this.y = START_Y;
        asteroidTexture = new Texture("Астероид.png");
    }

    private void random(){
        x = (float) (Math.random() * Gdx.graphics.getWidth());
        vY = (float) (1.5 + Math.random() * 0.5);
    }

    public void render(SpriteBatch batch){
        batch.draw(asteroidTexture, x, y);
    }

    public void update(){
        y -= vY;
        transferPictures();
    }

    void transferPictures(){
        if (y < -asteroidTexture.getHeight()) {
            random();
            y = START_Y;
        }
    }

    float getPositionY(){
        return y;
    }
    float getPositionX(){
        return x;
    }

    float getTextureSizeX(){
        return asteroidTexture.getWidth();
    }
}
