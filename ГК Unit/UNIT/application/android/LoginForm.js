'use strict';

import React, { Component } from 'react';
import { Image, StyleSheet, TouchableOpacity, Text, View, TextInput, Dimensions,
   } from 'react-native';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'flex-start',
    alignItems: 'center',
    backgroundColor: '#E3F2FD',
    paddingTop: 30,
  }, button: {
    backgroundColor: '#2196F3',
    width: 200,
    height: 40,
    justifyContent: 'center',
    alignItems: 'center',
  }, textInput: {
    width: Dimensions.get('window').width - 5,
    height: 40, borderColor: 'gray', borderWidth: 1,
    backgroundColor: '#fff',
    margin: 5
  }
});

class LoginForm extends Component {
   constructor(props) {
    super(props);
    this.state = {login: '', pass: ''};
  }

  login(){
    this.props.navigator.push({
      title: "List"
      });
  }

  testEnter(){
    
  }
  
  render() {
    return (
      <View style={styles.container}>
        <Image source={require('./img/logo.png')} style={{width: 150, height: 64}}/>
        <TextInput
          style={styles.textInput}
          placeholder="Логин"
          onChangeText={(login) => this.setState({login})}
          value={this.state.login}/>
        <TextInput
          style={styles.textInput}
          placeholder="Пароль"
          onChangeText={(pass) => this.setState({pass})}
          value={this.state.pass}
          secureTextEntry={true}/>
        <TouchableOpacity onPress={this.login.bind(this)} style={styles.button}>
          <Text style={{color: '#FFF', textAlign: 'center'}}>Войти</Text>
        </TouchableOpacity>
      </View>
    );
  }
}

module.exports = LoginForm;