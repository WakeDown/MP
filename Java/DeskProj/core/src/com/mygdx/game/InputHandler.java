package com.mygdx.game;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.math.Vector2;

/**
 * Created by trefi on 09.02.2016.
 */
public class InputHandler {
    public static boolean inClicked(){
        return Gdx.input.justTouched();
    }

    public static boolean inPressed(){
        return Gdx.input.isTouched();
    }

    public static Vector2 getMousePosition(){
        return new Vector2(Gdx.input.getX(),Gdx.graphics.getHeight() - Gdx.input.getY());
    }
}
