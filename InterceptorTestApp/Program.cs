var talkingEntity = new TalkingEntity();
talkingEntity.Talk("бее"); 
talkingEntity.Talk("гав гав"); 
talkingEntity.Talk("во славу императора"); 
class TalkingEntity
{
    public void Talk(string phrase)
        => Console.WriteLine($"Барашек говорит: {phrase}");
}