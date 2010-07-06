﻿using System;

namespace eXpand.ExpressApp.AdditionalViewControlsProvider {
    public class TypeDecorator : Attribute {
        readonly Type _controlType;
        readonly Type _defaultType;
        readonly bool _isDefaultDecorator;

        public TypeDecorator(Type controlType, Type defaultType, bool isDefaultDecorator) {
            _controlType = controlType;
            _defaultType = defaultType;
            _isDefaultDecorator = isDefaultDecorator;
        }

        public bool IsDefaultDecorator {
            get { return _isDefaultDecorator; }
        }

        public TypeDecorator(Type controlType) {
            _controlType = controlType;
        }

        public Type DefaultType {
            get { return _defaultType??_controlType; }
        }

        public Type ControlType {
            get { return _controlType; }
        }
    }
}