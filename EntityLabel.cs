using System;
using System.Collections.Generic;

namespace AuxisReFramework
{
    public class EntityLabel
    {
        public string name;
        public double? probability;
        public EntityLabel(string name_, double? probability_){
            name=name_;
            probability=probability_;
        }
        
        public Boolean overTreshhhold(){
            if (probability.HasValue && probability.Value >= 0.7){
                return true;
            }
            return false;
        }
    }
}