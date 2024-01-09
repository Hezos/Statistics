using Common;

namespace Common.ClassImplementation{
    public class Basic:BaseCalculation{

        public double RelativeError(double A, double a){
            return Division(a, A);
        }

        public double V(double A, double B){
            return Division(A, B);
        }

        //gi
        public double RelativeFrequency(double fi, double N){
            return Division(fi, N);
        }

        //Yi
        public double ClassMiddle(double Yi0, double Yin){
            return Multiply(0.5, Addition(Yi0, Yin));
        }

    }
}