'use strict';

import React, { Component } from 'react';
import { Navigator, BackAndroid } from 'react-native';
import Login from './LoginForm';
import List from './AgreementList'
import Info from './AgreementInfo'
var BaseConfig = Navigator.SceneConfigs.FloatFromRight;
var CustomSceneConfig = Object.assign({}, BaseConfig, {
  gestures: {}
});

class Container extends Component {
  constructor(props) {
    super(props);
    this.state = {title: null};
  }
  
  _configureScene(route) {
    return CustomSceneConfig;
  }
  
  renderScene(route, navigator) {
   if(route.title == 'Login') {
     return <Login navigator={navigator}/>
   } else if (route.title == 'List'){
     return <List navigator={navigator}/>
   }else if (route.title == 'Info'){
     return <Info navigator={navigator}/>
   }
}
  
  render() {
    //BackAndroid.addEventListener('hardwareBackPress', () => {});
    return (
      <Navigator
        initialRoute={{ title: 'Login' }}
        renderScene={this.renderScene.bind(this)}
        configureScene={this._configureScene}
      />
    );
    }
}

module.exports = Container;