package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.g2d.BitmapFont;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class MyGdxGame extends ApplicationAdapter {

	SpriteBatch batch;
	GameFon gameFon;
	MyRocket myRocket;
	BitmapFont bmf;
	Double scoreInText;
	private final int ASTEROIDSNUM = 10;
	Asteroids[] asteroids = new Asteroids[ASTEROIDSNUM];
	@Override
	public void create () {
		batch = new SpriteBatch();
		gameFon = new GameFon(0, 2.0f);
		myRocket = new MyRocket(5.0f);
		bmf = new BitmapFont(Gdx.files.internal("ScoreText.fnt"), Gdx.files.internal("ScoreText.png"), false);
		scoreInText = 0.0;
		for (int i = 0; i < ASTEROIDSNUM; i++) {
			asteroids[i] = new Asteroids();
		}
	}

	@Override
	public void render () {
		update();
		Gdx.gl.glClearColor(0, 0, 0, 1);
		Gdx.gl.glClear(GL20.GL_COLOR_BUFFER_BIT);
		batch.begin();
		gameFon.render(batch);
		myRocket.render(batch);
		for (int i = 0; i < ASTEROIDSNUM; i++) {
			asteroids[i].render(batch);
		}
		scoreInText += 0.02;
		bmf.draw(batch, "Score: " + String.format("%.0f", scoreInText), 10, 640);
		batch.end();
	}

	public void update(){
		gameFon.update();
		myRocket.update();
		for (int i = 0; i < ASTEROIDSNUM; i++) {
			asteroids[i].update();
		}
		crashConditions();
	}

	void crashConditions(){
		for (int i = 0; i < ASTEROIDSNUM; i++) {
			if (myRocket.getPositionX() >= asteroids[i].getPositionX() - asteroids[i].getTextureSizeX()
					&& asteroids[i].getPositionX() >= myRocket.getPositionX() + myRocket.getTextureSizeX()
					&& asteroids[i].getPositionY() <= myRocket.getPositionY()
					&& asteroids[i].getPositionY() >= 0)
				scoreInText = 0.0;
		}
	}
}
