class Animal
  def initialize type
    @animal_type = type
  end
  def make_noise
    puts "..."
  end
end

class Lion < Animal
  def initialize name
    super "Lion"
    @name = name
  end

  def make_noise
    puts "Roar!"
  end
end

class Duck < Animal
  def initialize name
    super "Duck"
    @name = name
  end

  def make_noise
    puts "Quack!"
  end
end

lion = Lion.new "Leo"
duck = Duck.new "Donald"

list = [lion,duck]

class MainProgram
  def make_all_animals_make_noise list_of_animals
    list_of_animals.each do |animal|
      animal.make_noise
    end
  end
end

run = MainProgram.new

run.make_all_animals_make_noise list