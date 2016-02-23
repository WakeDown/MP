package com.mygdx.game;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

/**
 * Created by trefi on 13.02.2016.
 */
public class MyRocket {
    private float x;
    private float vX;

    private static Texture rocketTexture;

    public MyRocket(float vX) {
        this.x = (Gdx.graphics.getWidth() / 2) - 49;
        this.vX = vX;
        rocketTexture = new Texture("Rocket.png");
    }

    public void render(SpriteBatch batch){
        batch.draw(rocketTexture, x, 0);
    }

    public void update(){
        transferPictures();
    }

    void transferPictures(){
        if(InputHandler.inPressed()){
            if (x < (InputHandler.getMousePosition().x - 49))
             x += vX;
            if (x > (InputHandler.getMousePosition().x - 49))
                x -= vX;
        }
    }

    float getPositionX(){
        return x;
    }

    float getPositionY(){
        return rocketTexture.getHeight();
    }

    float getTextureSizeX(){
        return rocketTexture.getWidth();
    }
}
