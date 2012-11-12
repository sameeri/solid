

class Lion
  def initialize type
    @species = type
  end

  def species
    @species
  end
end

class Duck
  def initialize type
    @species = type
  end

  def species
    @species
  end
end

class MainProgram
  def make_all_animals_make_noise list_of_animals
    list_of_animals.each do |animal|
      if animal.species == "Lion"
        puts "Roar!"
      elsif animal.species == "Duck"
        puts "Quack!"
      end
    end

  end
end

lion = Lion.new "Lion"
duck = Duck.new "Duck"
list = [lion,duck]

run = MainProgram.new

run.make_all_animals_make_noise list