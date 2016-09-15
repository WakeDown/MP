'use strict';

import React, { Component } from 'react';
import {
  AppRegistry,
} from 'react-native';
import Container from './application/android/Container';

class UNIT extends Component {
  render() {
    return (
      <Container/>
    );
  }
}

AppRegistry.registerComponent('UNIT', () => UNIT);