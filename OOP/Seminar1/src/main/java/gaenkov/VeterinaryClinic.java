package gaenkov;

import java.util.ArrayList;
import java.util.List;

public class VeterinaryClinic {
    private List<Goable> runners;
    private List<Flyable> flyers;
    private List<Swimable> swimmers;

    public VeterinaryClinic() {
        runners = new ArrayList<>();
        flyers = new ArrayList<>();
        swimmers = new ArrayList<>();
    }

    public void addRunner(Goable runner) {
        runners.add(runner);
    }

    public void addFlyer(Flyable flyer) {
        flyers.add(flyer);
    }

    public void addSwimmer(Swimable swimmer) {
        swimmers.add(swimmer);
    }

    public List<Goable> getAllRunners() {
        return runners;
    }

    public List<Flyable> getAllFlyers() {
        return flyers;
    }

    public List<Swimable> getAllSwimmers() {
        return swimmers;
    }

    public void treatAnimal(Doctor doctor, Object animal) {
        doctor.diagnose();
        doctor.prescribeMedicine();
    }

    public void provideCare(Nurse nurse, Object animal) {
        nurse.provideCare();
        nurse.administerMedicine();
    }
}

