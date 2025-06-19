package CommandPattern;

public class Main {
    public static void main(String[] args) {
        Light livingRoomLight = new Light();
        Command lightOn = new LightOnCommand(livingRoomLight);
        Command lightOff = new LightOffCommand(livingRoomLight);
        RemoteControl remote = new RemoteControl();
        System.out.println("Turning light ON:");
        remote.setCommand(lightOn);
        remote.pressButton();
        System.out.println("\nTurning light OFF:");
        remote.setCommand(lightOff);
        remote.pressButton();
    }
}
